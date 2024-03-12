using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class DataList<T>
    {
        private T[] _datas;
        public DataList()
        {
            _datas = Array.Empty<T>();
        }

        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;
        }
        public T[] GetAll()
        {
            return _datas;
        }

        public bool Delete(T data)
        {
            for (int i = 0; i < _datas.Length; i++)
            {
                if (_datas[i].Equals(data))
                {
                    for (int j = i; j < _datas.Length - 1; j++)
                    {
                        _datas[j] = _datas[j + 1];
                    }
                    Array.Resize(ref _datas, _datas.Length - 1);
                    return true;
                }
            }
            return false;
        }
        public bool Remove(T data)
        {
            int index=Array.IndexOf(_datas,data);  
            if (index == -1)
            {
                return false;
            }
            for(int i=index; i < _datas.Length-1; i++)
            {
                _datas[i] = _datas[i + 1];
            }
            Array.Resize(ref _datas,_datas.Length - 1);
            return true;
            
        }











    }
}
