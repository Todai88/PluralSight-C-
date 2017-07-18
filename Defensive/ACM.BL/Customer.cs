using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Manages a single customer.
    /// </summary>
    public class Customer
    {
        public int CustomerId   { get; set; }
        public string Email     { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }

        public OperationsResult ValidateEmail()
        {
            var op = new OperationsResult();

            var isValidFormat = true;
            var isRealDomain = true;
            if (op.Success)
            {

                if (string.IsNullOrWhiteSpace(this.Email))
                {
                    op.AddMessage("Email address is null");
                    op.Success = false;
                }    
            }

            if (op.Success)
            {
                if (!isValidFormat)
                {
                    op.AddMessage("Email address is not in a correct format");
                    op.Success = false;
                }  
            }

            if (op.Success)
            {
                if (!isRealDomain)
                {
                    op.AddMessage("Email address does not include a valid domain");
                    op.Success = false;
                }   
            }

            return op;
        } 

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            
            

            if (String.IsNullOrEmpty(goalSteps)) throw new ArgumentException("Goal must be enetered", "goalSteps");
            if (String.IsNullOrEmpty(actualSteps)) throw new ArgumentException("Actual steps must be enetered", "actualSteps");

            decimal goalStepCount = 0;
            if (!Decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException("Goal must be numeric");

            decimal actualStepCount = 0;
            if (!Decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual must be numeric", "actualSteps");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount < 0) throw new ArgumentException("Goal must be higher than 0", "goalSteps");

            return (actualStepCount / goalStepCount) * 100;
        }
    }
}
