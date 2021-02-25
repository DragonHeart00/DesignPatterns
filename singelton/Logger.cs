using System;

namespace DesignPatterns
{
    class Logger
    {


        private static Logger logger;
        
        //set constructor as a private 
        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            if(logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }
    }
}
