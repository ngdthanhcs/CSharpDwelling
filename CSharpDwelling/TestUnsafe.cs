using System.Runtime.InteropServices;

namespace StringTesting;

public static unsafe class TestUnsafe
{
    [StructLayout(LayoutKind.Sequential)]
    class Blittable
    {
        int x;
    }
    
    public static unsafe void GetAddress()
    {
        int i;
        object o = new Blittable();
        int* ptr = &i;
        IntPtr addr = (IntPtr)ptr;

        Console.WriteLine(addr.ToString("x"));

        GCHandle h = GCHandle.Alloc(o, GCHandleType.Pinned);
        addr = h.AddrOfPinnedObject();
        Console.WriteLine(addr.ToString("x"));

        h.Free();
    }
    
    public static void Main()
    {
        var s = "Hello, World!";
        var mod = s;

        mod += "-modified";

        unsafe
        {
            var p = &s;
            var p2 = &mod;
            /*Console.WriteLine(p);
            Console.WriteLine(p2);   */ 
        }
        
    }
}