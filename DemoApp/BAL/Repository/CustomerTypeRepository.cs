namespace DemoApp.BAL.Repository
{
    public class CustomerTypeRepository : Repository
    {
        /***
         * Example of simple implementation of CRUD operations
         * You can use it or define your own functionality

        public IList<CustomerTypeModel> Get()
        {
            return Context.CustomerTypes
                .Select(v =>
                    new CustomerTypeModel
                    {
                        Id = v.Id,
                        Description = v.Description
                    })
                .OrderBy(e => e.Description)
                .ToList();
        }

        public void Add(CustomerTypeModel customerType)
        {
            throw  new NotImplementedException();
        }
        public void Delete(CustomerTypeModel customerType)
        {
            throw  new NotImplementedException();
        }

        public void Update(CustomerTypeModel customerType)
        {
            throw  new NotImplementedException();
        }

        ***/
    }
}