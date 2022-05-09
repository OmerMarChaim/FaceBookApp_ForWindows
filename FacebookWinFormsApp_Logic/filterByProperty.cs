using System;
using System.Collections.Generic;
using System.Reflection;

namespace FacebookWinFormsApp_Logic
{
    public class FilterByProperty
    {
        private IClassifier m_Property;

        public IClassifier Property
        {
            get => m_Property;
            set => m_Property = value;
        }

        public FilterByProperty(IClassifier i_Property)
        {
            m_Property = i_Property;
        }

        public Dictionary<TKey, TValue> Filter<TKey, TValue>(Dictionary<TKey, TValue> i_Dictionary)
        {
            Dictionary<TKey, TValue> filteredDictionary = new Dictionary<TKey, TValue>();
            if(m_Property.GetType() == typeof(NonClassifier))
            {
                filteredDictionary = i_Dictionary;
            }
            else if(dictHasProperty(i_Dictionary))
            {
                Type typeOfKeys = i_Dictionary.Keys.GetType();
                PropertyInfo property = typeOfKeys.GetProperty(m_Property.GetPropertyName());
                foreach(KeyValuePair<TKey, TValue> pair in i_Dictionary)
                {
                    object propertyValueOfCurrentKey = property.GetValue(pair.Key);
                    if(m_Property.ShouldClassify(propertyValueOfCurrentKey as string))
                    {
                        filteredDictionary.Add(pair.Key, pair.Value);
                    }
                }
            }

            return filteredDictionary;
        }

        private bool dictHasProperty<TKey, TValue>(Dictionary<TKey, TValue> i_Dictionary)
        {
            Type typeOfKeys = i_Dictionary.Keys.GetType();
            bool hasProperty = false;
            foreach(PropertyInfo property in typeOfKeys.GetProperties())
            {
                if(property.Name == m_Property.GetPropertyName())
                {
                    hasProperty = true;
                }
            }

            return hasProperty;
        }
    }
}