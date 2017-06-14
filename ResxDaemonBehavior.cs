using System;

namespace JetBrains.ReSharper.Daemon
{
    [Language(typeof(ResxLanguage))]
    internal class ResxDaemonBehavior : XmlDaemonBehavior
    {
        public override ErrorStripeRequest InitialErrorStripe(IPsiSourceFile sourceFile)
        {
            return ErrorStripeRequest.STRIPE_AND_ERRORS;
        }

        
        
        
        
        
        
        
        
        
        
        
        public override bool Run
        {
            get { return true; }
        }
    }

    internal interface IPsiSourceFile
    {
    }

    internal class ErrorStripeRequest
    {
        public static ErrorStripeRequest STRIPE_AND_ERRORS;
    }
    
    internal class XmlDaemonBehavior
    {
        public virtual ErrorStripeRequest InitialErrorStripe(IPsiSourceFile sourceFile)
        {
            throw new NotImplementedException();
        }

        public virtual bool RunInSolutionAnalysis
        {
            get { throw new NotImplementedException(); }
        }

        public virtual bool Run
        {
            get { throw new NotImplementedException(); }
        }
    }

    internal class LanguageAttribute : Attribute
    {
        public LanguageAttribute(Type type)
        {
            throw new NotImplementedException();
        }
    }


    internal class ResxLanguage
    {
    }
    
}