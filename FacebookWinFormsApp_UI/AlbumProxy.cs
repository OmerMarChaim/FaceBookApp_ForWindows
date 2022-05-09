using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWinFormsApp_Logic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AlbumProxy
    {
        public Album m_Album;
        private List<User> m_BestLikers;
        private readonly Dictionary<User, int> r_LikesDict = new Dictionary<User, int>();
        private IClassifier m_Property;

        private AlbumProxy(Album i_Album)
        {
            m_Album = i_Album;
        }
        public IClassifier Property
        {
            get => m_Property;
            set => m_Property = value;
        }

        public List<User> bestLikers
        {
            get
            {
                if(m_BestLikers != null)
                {
                    return m_BestLikers;
                }
                else
                {
                    CalculateBestLiker(m_Property);

                    return m_BestLikers;
                }
            }
        }

    

        public static AlbumProxy GetNewAlbumProxy(Album i_Album)
        {
            return new AlbumProxy(i_Album);
        }

        internal void CalculateBestLiker(IClassifier i_PropertyToClassify)
        {
            FilterByProperty filter = new FilterByProperty(i_PropertyToClassify);
            Dictionary<User, int> filterDictionaryByClassifier = filter.Filter(r_LikesDict);
            foreach(KeyValuePair<User, int> pair in filterDictionaryByClassifier)
            {
                if(pair.Value == filterDictionaryByClassifier.Values.Max())
                {
                    m_BestLikers.Add(pair.Key);
                }
            }
        }
        public void FetchPhotosLikesFromAlbums(FacebookObjectCollection<User> i_PhotoLikedBy)
        {
            foreach(User user in i_PhotoLikedBy)
            {
                if(!r_LikesDict.ContainsKey(user))
                {
                    r_LikesDict.Add(user, 1);
                }
                else
                {
                    r_LikesDict[user] = r_LikesDict[user] + 1;
                }
            }
        }
    }
}