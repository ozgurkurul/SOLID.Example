namespace SOLIDs.InterfaceSegregationPrinciple.Unsuitable
{
    public interface IBaseApi
    {
        void Delete(int id);
        void Get(int id);
        void Post(int id);
        void Put(int id);
    }

    public class News : IBaseApi
    {
        public void Delete(int id) { }

        public void Get(int id) { }

        public void Post(int id) { }

        public void Put(int id) { }
    }
    public class Videos : IBaseApi
    {
        public void Delete(int id){}

        public void Get(int id){}

        public void Post(int id){}

        public void Put(int id){}
    }

    public class Notification : IBaseApi
    {
        public void Delete(int id) { }

        public void Get(int id) { }

        public void Post(int id) { }

        public void Put(int id) { }
    }
}

namespace SOLIDs.InterfaceSegregationPrinciple.Suitable
{
    public interface IGet
    {
        void Get(int id);
    }
    public interface IBaseApi : IGet
    {
        void Delete(int id);
        void Post(int id);
        void Put(int id);
    }

    public class News : IBaseApi
    {
        public void Delete(int id) { }

        public void Get(int id) { }

        public void Post(int id) { }

        public void Put(int id) { }
    }
    public class Videos : IBaseApi
    {
        public void Delete(int id) { }

        public void Get(int id) { }

        public void Post(int id) { }

        public void Put(int id) { }
    }

    public class Notification : IGet
    {

        public void Get(int id) { }
    }
}
