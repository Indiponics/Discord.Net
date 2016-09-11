using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Security.Cryptography
{
    //
    // Summary:
    //     Implements password-based key derivation functionality, PBKDF2, by using a pseudo-random
    //     number generator based on System.Security.Cryptography.HMACSHA1.
    public class Rfc2898DeriveBytes 
    {
        //
        // Summary:
        //     Initializes a new instance of the System.Security.Cryptography.Rfc2898DeriveBytes
        //     class using the password and salt size to derive the key.
        //
        // Parameters:
        //   password:
        //     The password used to derive the key.
        //
        //   saltSize:
        //     The size of the random salt that you want the class to generate.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The specified salt size is smaller than 8 bytes.
        //
        //   T:System.ArgumentNullException:
        //     The password or salt is null.
        public Rfc2898DeriveBytes(string password, int saltSize) { }
        //
        // Summary:
        //     Initializes a new instance of the System.Security.Cryptography.Rfc2898DeriveBytes
        //     class using a password and salt to derive the key.
        //
        // Parameters:
        //   password:
        //     The password used to derive the key.
        //
        //   salt:
        //     The key salt used to derive the key.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The specified salt size is smaller than 8 bytes or the iteration count is less
        //     than 1.
        //
        //   T:System.ArgumentNullException:
        //     The password or salt is null.
        public Rfc2898DeriveBytes(string password, byte[] salt) { }
        //
        // Summary:
        //     Initializes a new instance of the System.Security.Cryptography.Rfc2898DeriveBytes
        //     class using a password, a salt size, and number of iterations to derive the key.
        //
        // Parameters:
        //   password:
        //     The password used to derive the key.
        //
        //   saltSize:
        //     The size of the random salt that you want the class to generate.
        //
        //   iterations:
        //     The number of iterations for the operation.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The specified salt size is smaller than 8 bytes or the iteration count is less
        //     than 1.
        //
        //   T:System.ArgumentNullException:
        //     The password or salt is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     iterations is out of range. This parameter requires a non-negative number.
        private Rfc2898DeriveBytes(string password, int saltSize, int iterations) { }
        //
        // Summary:
        //     Initializes a new instance of the System.Security.Cryptography.Rfc2898DeriveBytes
        //     class using a password, a salt, and number of iterations to derive the key.
        //
        // Parameters:
        //   password:
        //     The password used to derive the key.
        //
        //   salt:
        //     The key salt used to derive the key.
        //
        //   iterations:
        //     The number of iterations for the operation.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The specified salt size is smaller than 8 bytes or the iteration count is less
        //     than 1.
        //
        //   T:System.ArgumentNullException:
        //     The password or salt is null.
        private Rfc2898DeriveBytes(string password, byte[] salt, int iterations) { }
        //
        // Summary:
        //     Initializes a new instance of the System.Security.Cryptography.Rfc2898DeriveBytes
        //     class using a password, a salt, and number of iterations to derive the key.
        //
        // Parameters:
        //   password:
        //     The password used to derive the key.
        //
        //   salt:
        //     The key salt used to derive the key.
        //
        //   iterations:
        //     The number of iterations for the operation.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The specified salt size is smaller than 8 bytes or the iteration count is less
        //     than 1.
        //
        //   T:System.ArgumentNullException:
        //     The password or salt is null.
        private Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations) { }

        //
        // Summary:
        //     Gets or sets the number of iterations for the operation.
        //
        // Returns:
        //     The number of iterations for the operation.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The number of iterations is less than 1.
        private int IterationCount { get; set; }
        //
        // Summary:
        //     Gets or sets the key salt value for the operation.
        //
        // Returns:
        //     The key salt value for the operation.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The specified salt size is smaller than 8 bytes.
        //
        //   T:System.ArgumentNullException:
        //     The salt is null.
        private byte[] Salt { get; set; }

        //
        // Summary:
        //     Returns the pseudo-random key for this object.
        //
        // Parameters:
        //   cb:
        //     The number of pseudo-random key bytes to generate.
        //
        // Returns:
        //     A byte array filled with pseudo-random key bytes.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     cb is out of range. This parameter requires a non-negative number.
        public byte[] GetBytes(int cb) { return null; }
        //
        // Summary:
        //     Resets the state of the operation.
        private void Reset() { }
        //
        // Summary:
        //     Releases the unmanaged resources used by the System.Security.Cryptography.Rfc2898DeriveBytes
        //     class and optionally releases the managed resources.
        //
        // Parameters:
        //   disposing:
        //     true to release both managed and unmanaged resources; false to release only unmanaged
        //     resources.
        private void Dispose(bool disposing) { }
    }
}
