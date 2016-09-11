using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Security.Cryptography
{
    //
    // Summary:
    //     Represents the abstract base class from which all implementations of the Advanced
    //     Encryption Standard (AES) must inherit.
    public abstract class Aes 
    {
        //
        // Summary:
        //     Initializes a new instance of the System.Security.Cryptography.Aes class.
        protected Aes() { }

        //
        // Summary:
        //     Creates a cryptographic object that is used to perform the symmetric algorithm.
        //
        // Returns:
        //     A cryptographic object that is used to perform the symmetric algorithm.
        public static Aes Create() { return null; }
        //
        // Summary:
        //     Creates a cryptographic object that specifies the implementation of AES to use
        //     to perform the symmetric algorithm.
        //
        // Parameters:
        //   algorithmName:
        //     The name of the specific implementation of AES to use.
        //
        // Returns:
        //     A cryptographic object that is used to perform the symmetric algorithm.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The algorithmName parameter is null.
        public static Aes Create(string algorithmName) { return null; }
    }
}
