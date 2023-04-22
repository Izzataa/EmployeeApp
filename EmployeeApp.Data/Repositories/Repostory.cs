using EmployeeApp.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Data.Repositories
{
    public  class Repostory<T> where T : BaseModel
    {
        private readonly List<T> _items = new List<T>();
        public void Create(T model)
        {
            _items.Add(model);
        }
    public void Delete(T model)     
        {
            _items.Remove(model);
        }

        public T Get(Func<T, bool> func)
        {
            return _items.FirstOrDefault(func);
                }
         public List<T> GetAll() {
        return _items;
            }  
        
        }
    }

    
    

