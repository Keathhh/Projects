using System;
using System.Collections;
using System.Collections.Generic;


namespace SwinAdventures
{
    public class GameObject : IdentifiableObject
    {
        private string _description, _name;

        public GameObject(string[] ids, string name, string desc) : base(ids)
        {
            _name = name;
            _description = desc;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public virtual string FullDescription
        {
            get
            {
                return _description;
            }
        }

        public string ShortDescription
        {
            get
            {
                string shortDescription = $"{_name} ({FirstID})";
                return shortDescription;
            }
        }

    }
}

