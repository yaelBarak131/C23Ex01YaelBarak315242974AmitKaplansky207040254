using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class PastView
    {
        private readonly User r_User;
        private Dictionary<int, LinkedList<Post>> m_YearToPostDict = new Dictionary<int, LinkedList<Post>>();
        private Dictionary<int, LinkedList<Album>> m_YearToAlbumDict = new Dictionary<int, LinkedList<Album>>();

        public Dictionary<int, LinkedList<Post>> YearToPostDict
        {
            get
            {
                return m_YearToPostDict;
            }
        }

        public Dictionary<int, LinkedList<Album>> YearToAlbumDict
        {
            get
            {
                return m_YearToAlbumDict;
            }
        }

        private void createYearToPostDict()
        {
            int createdYearOfPost;

            foreach (Post post in r_User.Posts)
            {
                createdYearOfPost = post.CreatedTime.Value.Year;

                if (post.Message != null)
                {
                    if (!m_YearToPostDict.ContainsKey(createdYearOfPost))
                    {
                        m_YearToPostDict[createdYearOfPost] = new LinkedList<Post>();
                    }

                    m_YearToPostDict[createdYearOfPost].AddLast(post);
                }
            }
        }

        private void createYearToAlbumDict()
        {
            int createdYearOfPost;

            foreach (Album album in r_User.Albums)
            {
                createdYearOfPost = album.CreatedTime.Value.Year;

                if (album != null)
                {
                    if (!m_YearToAlbumDict.ContainsKey(createdYearOfPost))
                    {
                        m_YearToAlbumDict[createdYearOfPost] = new LinkedList<Album>();
                    }

                    m_YearToAlbumDict[createdYearOfPost].AddLast(album);
                }
            }
        }

        public PastView(User i_User)
        {
            this.r_User = i_User;
            createYearToPostDict();
            createYearToAlbumDict();
        }
    }
}
