using System;
using System.Collections.Generic;
using System.Text;

namespace Entreprise.Exceptions
{
    public class SocieteException : Exception
    {
        public SocieteException()
        {          
        }

        public SocieteException(string message) : base(message)
        {
        }

        public SocieteException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }


    public class TravailleurException : SocieteException
    {
        public TravailleurException()
        {
        }

        public TravailleurException(string message) : base(message)
        {
        }

        public TravailleurException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class EmployeException : TravailleurException
    {
        public EmployeException()
        {
        }

        public EmployeException(string message) : base(message)
        {
        }

        public EmployeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class EmployeExceptionSalaireTropEleve : TravailleurException
    {


        public EmployeExceptionSalaireTropEleve()
        {
        }

        public EmployeExceptionSalaireTropEleve(string message) : base(message)
        {
        }

        public EmployeExceptionSalaireTropEleve(string message, Exception innerException) : base(message, innerException)
        { 
        }
    }




    public class OuvrierException : TravailleurException
    {
        public OuvrierException()
        {
        }

        public OuvrierException(string message) : base(message)
        {
        }

        public OuvrierException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
