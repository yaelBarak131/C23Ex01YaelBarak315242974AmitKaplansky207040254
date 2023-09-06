using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{

    public class PostsToYears
    {
        private readonly User r_User;
        private Dictionary<string, int> m_PostsToYears = new Dictionary<string, int>();

        public PostsToYears(User i_User)
        {
            this.r_User = i_User;

            foreach (Post post in r_User.Posts)
            {
                if (post.Message != null)
                {
                    m_PostsToYears.Add(post.Message, post.CreatedTime.Value.Year);
                }
            }
        }

        public Dictionary<string, int> PostsToYearDict
        {
            get
            {
                return m_PostsToYears;
            }
        }

    }
}
