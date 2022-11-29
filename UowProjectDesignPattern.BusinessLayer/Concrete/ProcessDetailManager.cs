using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UowProjectDesignPattern.BusinessLayer.Abstract;
using UowProjectDesignPattern.EntityLayer.Concrete;

namespace UowProjectDesignPattern.BusinessLayer.Concrete
{
    public class ProcessDetailManager : IProcessDetailService
    {
        public void TDelete(ProcessDetail t)
        {
            throw new NotImplementedException();
        }

        public ProcessDetail TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProcessDetail> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(ProcessDetail t)
        {
            throw new NotImplementedException();
        }

        public void TMultiUpdate(List<ProcessDetail> t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ProcessDetail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdateRange(List<ProcessDetail> t)
        {
            throw new NotImplementedException();
        }
    }
}
