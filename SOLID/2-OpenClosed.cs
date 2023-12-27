using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // This principle says that it should be possible to extend functionality in classes without modifying the existing code in the classes.
    // it should be possible to extend the behaviour of the software without modifying its core existing implementation.
    public class OpenClosed
    {
    }

    public interface IUploadOrderFile
    {
        object ProcessOrderFile();
    }

    public class UploadXMLOrderFile : IUploadOrderFile
    {
        public object ProcessOrderFile()
        {
            object orderObj = null;

            //Parse XML File to DTO Object

            return orderObj;
        }
    }

    public class UploadJSONOrderFile : IUploadOrderFile
    {
        public object ProcessOrderFile()
        {
            object orderObj = null;

            //Parse JSON File to DTO Object

            return orderObj;
        }
    }

    public class UploadProcess
    {
        public bool UploadFile()
        {
            IUploadOrderFile orderFile = null;

            //if XML File
            {
                orderFile = new UploadXMLOrderFile();
            }

            //if JSON File
            {
                orderFile = new UploadJSONOrderFile();
            }

            Object orderObj = orderFile.ProcessOrderFile();

            //Validate Records

            //Save Records

            return true;
        }
    }
}
