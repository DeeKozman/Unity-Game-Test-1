using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameStuff.Interfaces;


namespace GameStuff.Utility.Databases
{
    public abstract class AbstractDatabase<T> : ScriptableObject where T : IDatabaseAsset
    {

        [SerializeField] private List<T> _objects;

        protected List<T> Objects
        {
            get
            {
                if (_objects == null)
                    _objects = new List<T>();
                return _objects;
            }
        }

        protected abstract void OnAddObject(T t);

        protected abstract void OnRemoveObject(T t);

        public int Count
        {
            get { return Objects.Count; }
        }

        public void Add(T t)
        {
            Objects.Add(t);
            OnAddObject(t);
        }

        public void Remove(T t)
        {
            Objects.Remove(t);
            OnRemoveObject(t);
        }

        public void RemoveAt(int index)
        {
            var obj = Objects[index];
            Objects.RemoveAt(index);
            OnRemoveObject(obj);
        }

        public void Replace(int index, T t)
        {
            var old = Objects[index];
            Objects[index] = t;
            OnRemoveObject(old);
            OnAddObject(t);
        }

        public bool Contains(T t)
        {
            return Objects.Contains(t);
        }

        public T GetAtIndex(int index)
        {
            if (Count > 0)
            {
                if (index >= 0 && index < Count)
                    return Objects[index];
                return default(T);
            }
            return default(T);
        }

        public T GetById(int id)
        {
            for (int i = 0; i < Count; i++)
            {
                var asset = GetAtIndex(i);
                if (asset.Id == id)
                {
                    return (T)GetAtIndex(i);
                }
            }
            return default(T);
        }

        public int GetFirstAvalibleId()
        {
            if (Count <= 0)
            {
                return 1;
            }
            else
            {
                int target = 1;
                bool found = false;
                while (!found)
                {
                    found = true;
                    for (int i = 0; i < Count; i++)
                    {
                        if (GetAtIndex(i).Id == target)
                        {
                            found = false;
                            target++;
                            break;
                        }
                    }
                }
                return target;
            }
        }

        public int GetNextId()
        {
            if (Count <= 0)
            {
                return 1;
            }
            else
            {
                int maxId = 1;
                for (int i = 0; i < Count; i++)
                {
                    var asset = GetAtIndex(i);
                    if (asset.Id > maxId)
                    {
                        maxId = asset.Id;
                    }
                }
                return maxId + 1;
            }
        }

        public bool ContainsDuplicateId()
        {
            for (int i = 0; i < Count - 1; i++)
            {
                var asset1 = GetAtIndex(i);
                for (int j = i + 1; j < Count; j++)
                {
                    var asset2 = GetAtIndex(j);
                    if (asset1.Id == asset2.Id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

       // static public U GetDatabase<U>(string dbPath, string dbName) where U : ScriptableObject
       // {
//#if UNITY_EDITOR
            /*
            string dbFullPath = @"Assets/" + dbPath + dbName;
           U database = AssetDatabase.LoadAssetAtPath<U>(dbFullPath);

            if (database == null)
            {
                System.IO.Directory.CreateDirectory(Application.dataPath + "/" + dbPath);
                database = ScriptableObject.CreateInstance<U>();
                AssetDatabase.CreateAsset(database, dbFullPath);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }

            return database;*/
/*#else

            Debug.LogFormat("Loading Database at path ({0}) with name {1}", dbPath, dbName);
            var db = Resources.Load<U>(dbPath.Replace("Resources/", "") + dbName.Replace(".asset", ""));
            if (db == null) {
            Debug.Log("No Database found");
            return null;
            } else {
                Debug.Log("Sweet Jesus, We have a database!");
                return db;
            }
#endif
        }*/
    }

}