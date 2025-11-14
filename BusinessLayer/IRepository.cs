using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IRepository<T>
    {
        //Läs på om asykrom programmering, Task och Lambda uttryck (chatt föreslår tasks) klassen är inte klar
        //Create
        void Add(T item);
        //Read
        List<T> GetAll();
        //Read 
        T? GetById(int id);
        //Update
        bool Update (T item);
        //Delete
        bool Delete(int item);
        

    }
}
