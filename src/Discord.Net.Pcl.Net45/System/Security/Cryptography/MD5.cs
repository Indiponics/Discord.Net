using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Security.Cryptography
{
    //
    // Summary:
    //     Represents the abstract class from which all implementations of the System.Security.Cryptography.MD5
    //     hash algorithm inherit.
    public abstract class MD5: IDisposable
    {
        //
        // Summary:
        //     Initializes a new instance of System.Security.Cryptography.MD5.
        protected MD5() { }

        //
        // Summary:
        //     Creates an instance of the default implementation of the System.Security.Cryptography.MD5
        //     hash algorithm.
        //
        // Returns:
        //     A new instance of the System.Security.Cryptography.MD5 hash algorithm.
        //
        // Exceptions:
        //   T:System.Reflection.TargetInvocationException:
        //     The algorithm was used with Federal Information Processing Standards (FIPS) mode
        //     enabled, but is not FIPS compatible.
        public static MD5 Create() { return null; }
        //
        // Summary:
        //     Creates an instance of the specified implementation of the System.Security.Cryptography.MD5
        //     hash algorithm.
        //
        // Parameters:
        //   algName:
        //     The name of the specific implementation of System.Security.Cryptography.MD5 to
        //     use.
        //
        // Returns:
        //     A new instance of the specified implementation of System.Security.Cryptography.MD5.
        //
        // Exceptions:
        //   T:System.Reflection.TargetInvocationException:
        //     The algorithm described by the algName parameter was used with Federal Information
        //     Processing Standards (FIPS) mode enabled, but is not FIPS compatible.
        public static MD5 Create(string algName) { return null; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Computes the hash value for the specified System.IO.Stream object.
        //
        // Parameters:
        //   inputStream:
        //     The input to compute the hash code for.
        //
        // Returns:
        //     The computed hash code.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The object has already been disposed.
        public byte[] ComputeHash(Stream inputStream) { return null; }
        //
        // Summary:
        //     Computes the hash value for the specified byte array.
        //
        // Parameters:
        //   buffer:
        //     The input to compute the hash code for.
        //
        // Returns:
        //     The computed hash code.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     buffer is null.
        //
        //   T:System.ObjectDisposedException:
        //     The object has already been disposed.
        public byte[] ComputeHash(byte[] buffer) { return null; }
        //
        // Summary:
        //     Computes the hash value for the specified region of the specified byte array.
        //
        // Parameters:
        //   buffer:
        //     The input to compute the hash code for.
        //
        //   offset:
        //     The offset into the byte array from which to begin using data.
        //
        //   count:
        //     The number of bytes in the array to use as data.
        //
        // Returns:
        //     The computed hash code.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     count is an invalid value.-or-buffer length is invalid.
        //
        //   T:System.ArgumentNullException:
        //     buffer is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     offset is out of range. This parameter requires a non-negative number.
        //
        //   T:System.ObjectDisposedException:
        //     The object has already been disposed.
        public byte[] ComputeHash(byte[] buffer, int offset, int count) { return null; }
    }
}
