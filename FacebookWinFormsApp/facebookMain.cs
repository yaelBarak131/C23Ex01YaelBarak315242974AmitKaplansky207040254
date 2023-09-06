using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class facebookMain : Form
    {
        private FacebookWrapper.LoginResult m_LoginResult;
        private User m_UserLoggedIn;
        private PostsToYears m_PostsToYears;
        private PastView m_pastView;

        public facebookMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_UserLoggedIn == null)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                "820454999658659",
                 "email",
                     "public_profile",
                     "user_age_range",
                     "user_birthday",
                     "user_events",
                     "user_friends",
                     "user_gender",
                     "user_hometown",
                     "user_likes",
                     "user_link",
                     "user_location",
                     "user_photos",
                     "user_posts",
                     "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_UserLoggedIn = m_LoginResult.LoggedInUser;

                buttonLogin.Text = $"Logged in as {m_UserLoggedIn.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_UserLoggedIn.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                getPosts();
                getLikedPages();
                getFriends();
                getAlbums();
                createComboBoxs();
                m_pastView = new PastView(m_UserLoggedIn);
                m_PostsToYears = new PostsToYears(m_UserLoggedIn);


            }


            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed!");
            }
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void getPosts()
        {
            PostsListBox.Items.Clear();

            foreach (Post post in m_UserLoggedIn.Posts)
            {
                if (post.Message != null)
                {
                    PostsListBox.Items.Add(post.Message);
                }
             
            }

            if( m_UserLoggedIn.Posts.Count == 0)
            {
                PostsListBox.Items.Add("No Posts in this account");
                PostsListBox.Enabled = false;
            }

        }

        private void getLikedPages()
        {
            LikedPagesListBox.Enabled = true;
            LikedPagesListBox.Items.Clear();
            LikedPagesListBox.DisplayMember = "Name";
            
            foreach (Page page in m_UserLoggedIn.LikedPages)
            {   
                if (page != null)
                {
                    LikedPagesListBox.Items.Add(page);
                    
                }
                   
            }


            if (LikedPagesListBox.Items.Count == 0)
            {
                LikedPagesListBox.Items.Add("No liked pages in this account");
                LikedPagesListBox.Enabled = false;
            }
        }


        private void getFriends()
        {
            FriendsListBox.Items.Clear();
            FriendsListBox.Enabled = true;
            FriendsListBox.DisplayMember = "Name";
            
            foreach (User friend in m_UserLoggedIn.Friends)
            {
                if( friend != null)
                {
                    FriendsListBox.Items.Add(friend);
                }
            }
            

            if (FriendsListBox.Items.Count == 0)
            {
                FriendsListBox.Items.Add("This app has no friends in this account");
                FriendsListBox.Enabled = false;
            }
        }

        private void getAlbums()
        {
            AlbumsListBox.Items.Clear();
            AlbumsListBox.DisplayMember = "Name";
            foreach (Album album in m_UserLoggedIn.Albums)
            {
                if (album != null)
                {
                    AlbumsListBox.Items.Add(album);
                }
            }

            if (AlbumsListBox.Items.Count == 0)
            {
                AlbumsListBox.Items.Add("No albums in this account");
                AlbumsListBox.Enabled = false;
            }
        }
        private void showSelectedAlbum(ListBox i_ListBox, PictureBox i_PictureBox)
        {
            if (i_ListBox.SelectedItems.Count == 1)
            {
                Album selectedAlbum = i_ListBox.SelectedItem as Album;
               
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    i_PictureBox.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    i_PictureBox.Image = i_PictureBox.ErrorImage;
                }
            }
        }
        private void AlbumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSelectedAlbum(AlbumsListBox, AlbumsPictureBox);
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultGameLabel.Text = "";
        }

        private void CheckAnswerGuessPostYear_Click(object sender, EventArgs e)
        {
            resultGameLabel.Text = "";

            if (guessPostLabel.Text != "" && ChooseYearComboBox.SelectedItem != null)
            {
                Dictionary<string, int> postsToYearDict = m_PostsToYears.PostsToYearDict;

                if (ChooseYearComboBox.SelectedItem.ToString() ==
                    postsToYearDict[guessPostLabel.Text].ToString())
                {
                    resultGameLabel.Text = "You are Currect";
                    renderNewPostMessage();
                }
                else
                {
                    resultGameLabel.Text = "You are wrong, try again";
                }
            }
        }


        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (m_UserLoggedIn != null)
            {
                resultGameLabel.Text = "";
                renderNewPostMessage();
            }
            else
            {
                resultGameLabel.Text = "You need to login first.";

            }
        }

        private void renderNewPostMessage()
        {
            Dictionary<string, int> postsToYearDict = m_PostsToYears.PostsToYearDict;

            if (postsToYearDict.Count != 0)
            {
                Random random = new Random();
                int randomIndexInDictionary = random.Next(postsToYearDict.Count);
                KeyValuePair<string, int> randomPostPair = postsToYearDict.ElementAt(randomIndexInDictionary);
                guessPostLabel.Text = randomPostPair.Key;
            }
            else
            {
                guessPostLabel.Text = "No posts in this account";
                ChooseYearComboBox.Enabled = true;
                checkAnswerGameButton.Enabled = true;
                startGameButton.Enabled = true;
            }
        }

    
        private void pastViewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_UserLoggedIn != null)
            {
                int selectedYear = int.Parse(pastViewComboBox.SelectedItem.ToString());

                errorMessage.Text = "";
                pastPostsListBox.Items.Clear();

                if (m_pastView.YearToPostDict.ContainsKey(selectedYear))
                {
                    foreach (Post post in m_pastView.YearToPostDict[selectedYear])
                    {
                        pastPostsListBox.Items.Add(post);
                    }
                }
                else
                {
                    pastPostsListBox.Items.Add("No Posts found");
                    pastPostsListBox.Enabled = false;
                }

                pastAlbumsListBox.Items.Clear();
                pastAlbumsListBox.DisplayMember = "Name";

                if (m_pastView.YearToAlbumDict.ContainsKey(selectedYear))
                {
                    foreach (Album album in m_pastView.YearToAlbumDict[selectedYear])
                    {
                        pastAlbumsListBox.Items.Add(album);
                    }
                }
                else
                {
                    pastAlbumsListBox.Items.Add("No albums found");
                    pastAlbumsListBox.Enabled = false;
                }
            }
            else
            {
                errorMessage.Text = "You need to login first.";

            }

        }

        private void createComboBoxs()
        {

            int firstPostYear = DateTime.Now.Year;
            int currentYear;

            pastViewComboBox.Items.Clear();
            ChooseYearComboBox.Items.Clear();

            foreach (Post post in m_UserLoggedIn.Posts)
            {
                currentYear = post.CreatedTime.Value.Year;

                if (post.Message != null && currentYear < firstPostYear)
                {
                    firstPostYear = currentYear;
                }
            }

            for (int i = firstPostYear; i <= DateTime.Now.Year; i++)
            {
                ChooseYearComboBox.Items.Add(i);
                pastViewComboBox.Items.Add(i);
            }
        }

        private void pastAlbumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSelectedAlbum(pastAlbumsListBox, PastAlbumsPictureBox);
        }

      
    }
}
