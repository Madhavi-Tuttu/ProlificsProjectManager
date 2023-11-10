namespace PPM.Model
{
    public interface Ioperation<T>
    {
        void Add(T obj);
 
        T GetById(int Id);
 
        void Delete(int Id);
 
        public bool CheckId(int pId);
    }
}