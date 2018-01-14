using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //************************************************************************************
    // Overloaded Operators +, -, *, /, %, >>, <<, ==, !=, >, <, >=, <=, &, |, ^, ++, --, ~
    //
    // Features
    // --------
    // 1) Arithmetic operations involving large signed integers (2's complement).
    // 2) Primality test using Fermat little theorm, Rabin Miller's method,
    //    Solovay Strassen's method and Lucas strong pseudoprime.
    // 3) Modulo exponential with Barrett's reduction.
    // 4) Inverse modulo.
    // 5) Pseudo prime generation.
    // 6) Co-prime generation.
    //
    //
    // References
    // [1] D. E. Knuth, "Seminumerical Algorithms", The Art of Computer Programming Vol. 2,
    //     3rd Edition, Addison-Wesley, 1998.
    //
    // [2] K. H. Rosen, "Elementary Number Theory and Its Applications", 3rd Ed,
    //     Addison-Wesley, 1993.
    //
    // [3] B. Schneier, "Applied Cryptography", 2nd Ed, John Wiley & Sons, 1996.
    //
    // [4] A. Menezes, P. van Oorschot, and S. Vanstone, "Handbook of Applied Cryptography",
    //     CRC Press, 1996, www.cacr.math.uwaterloo.ca/hac
    //
    // [5] A. Bosselaers, R. Govaerts, and J. Vandewalle, "Comparison of Three Modular
    //     Reduction Functions," Proc. CRYPTO'93, pp.175-186.
    //
    // [6] R. Baillie and S. S. Wagstaff Jr, "Lucas Pseudoprimes", Mathematics of Computation,
    //     Vol. 35, No. 152, Oct 1980, pp. 1391-1417.
    //
    // [7] H. C. Williams, "Édouard Lucas and Primality Testing", Canadian Mathematical
    //     Society Series of Monographs and Advance Texts, vol. 22, John Wiley & Sons, New York,
    //     NY, 1998.
    //
    // [8] P. Ribenboim, "The new book of prime number records", 3rd edition, Springer-Verlag,
    //     New York, NY, 1995.
    //
    // [9] M. Joye and J.-J. Quisquater, "Efficient computation of full Lucas sequences",
    //     Electronics Letters, 32(6), 1996, pp 537-538.
    //
    //************************************************************************************

    public abstract class BigIntegerBase
    {
        protected const int maxDigits = 10;
    }
    public class BigInteger: BigIntegerBase
    {
        // maximum length of the BigInteger in uint (4 bytes)
        // change this to suit the required level of precision.


        private uint[] digits = null;           // array of digits representing the big int
                                                // the size of the array corresponds to the largest 
                                                // number of digits the class can handle
        public int numberOfDigits;         // number of actual digits in this instance of the big int

        public BigInteger()
        {   
            // default constructor: value = 0
            digits = new uint[maxDigits];
            numberOfDigits = 1;
        }
    }
}
