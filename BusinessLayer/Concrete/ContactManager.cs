using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _connactDal;

        public ContactManager(IContactDal connactDal)
        {
            _connactDal = connactDal;
        }

        public void Delete(Contact t)
        {
           _connactDal.Delete(t);
        }

        public Contact GetById(int id)
        {
            return _connactDal.GetById(id);
        }

        public List<Contact> GetListAll()
        {
            return _connactDal.GetListAll();
        }

        public void Insert(Contact t)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
