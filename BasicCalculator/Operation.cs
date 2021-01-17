using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator

{
    /// <summary>
    /// Holds information about a single calculator opeartion
    /// </summary>
    public class Operation
    {

        #region public properties

        /// <summary>
        /// The left side of the operation
        /// </summary>

        public string LeftSide { get; set; }

        // the right side of the operation


        public string RightSide { get; set; }
 
    public OperationType OperationType { get; set; }

        // the inner operation  to be performed initially before this opertaion 

        public Operation InnerOperation { get; set; }
      
        #endregion

        public Operation()
        {

        }
    }
}