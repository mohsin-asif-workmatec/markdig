﻿using System;
using System.Collections.Generic;

namespace Textamina.Markdig.Syntax
{
    public class MarkdownObject
    {
        private Dictionary<object, object> attachedDatas;

        public void SetData(object key, object value)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (attachedDatas == null)
            {
                attachedDatas = new Dictionary<object, object>();
            }
            attachedDatas[key] = value;
        }

        public bool ContainsData(object key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (attachedDatas == null)
            {
                return false;
            }
            return attachedDatas.ContainsKey(key);
        }

        public object GetData(object key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (attachedDatas == null)
            {
                return null;
            }
            object value;
            attachedDatas.TryGetValue(key, out value);
            return value;
        }

        public bool RemoveData(object key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (attachedDatas == null)
            {
                return true;
            }
            return attachedDatas.Remove(key);
        }
    }
}