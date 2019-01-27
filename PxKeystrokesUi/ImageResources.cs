using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PxKeystrokesUi
{
    class ImageResources
    {
        static Assembly _assembly;
        //static Stream _imageStream;

        public static Bitmap BMouse;
        public static Bitmap BLeft;
        public static Bitmap BRight;
        public static Bitmap BMiddle;
        public static Bitmap BLeftDouble;
        public static Bitmap BRightDouble;
        //public static Bitmap BWheel;
        public static Bitmap BWheelUp;
        public static Bitmap BWheelDown;

        public static Metafile MMouse;
        public static Metafile MLeft;
        public static Metafile MRight;
        public static Metafile MMiddle;
        public static Metafile MLeftDouble;
        public static Metafile MRightDouble;
        //public static Metafile MWheel;
        public static Metafile MWheelUp;
        public static Metafile MWheelDown;


        [System.Runtime.InteropServices.DllImport("kernel32.dll")] // この行を追加
        private static extern bool AllocConsole();
        public static void Init()
        {
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                
                foreach(string i in _assembly.GetManifestResourceNames())
                {
                    Log.e("RES", i);
                }
                BMouse = new Bitmap(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse.png"));
                BLeft = new Bitmap(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_left.png"));
                BRight = new Bitmap(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_right.png"));
                BMiddle = new Bitmap(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_middle.png"));
                BLeftDouble = new Bitmap(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_left_double.png"));
                BRightDouble = new Bitmap(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_right_double.png"));
                BWheelUp = new Bitmap(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_wheel_up.png"));
                BWheelDown = new Bitmap(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_wheel_down.png"));

                MMouse = new Metafile(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_base.emf"));
                MLeft = new Metafile(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_left.emf"));
                MRight = new Metafile(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_right.emf"));
                MMiddle = new Metafile(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_middle.emf"));
                MLeftDouble = new Metafile(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_left_double.emf"));
                MRightDouble = new Metafile(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_right_double.emf"));
                MWheelUp = new Metafile(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_wheel_up.emf"));
                MWheelDown = new Metafile(_assembly.GetManifestResourceStream("PxKeystrokesUi.Resources.mouse_wheel_down.emf"));
                
                using (Bitmap testBitmap = new Bitmap(MMouse))
                {
                    using (Graphics gr = Graphics.FromImage(testBitmap))
                    {
                        Graphics.EnumerateMetafileProc metafileDelegate = new Graphics.EnumerateMetafileProc(EnumMetaCB);
                    }
                    bool MetafileCallback(EmfPlusRecordType recordType, int flags, int dataSize,IntPtr data, PlayRecordCallback callbackData)
                    {
                        byte[] dataArray = null;
                        if (data != IntPtr.Zero)
                        {
                            // Copy the unmanaged record to a managed byte buffer 
                            // that can be used by PlayRecord.
                            dataArray = new byte[dataSize];
                            Marshal.Copy(data, dataArray, 0, dataSize);
                        }

                        MMouse.PlayRecord(recordType, flags, dataSize, dataArray);

                        return true;
                    }
                    bool EnumMetaCB(EmfPlusRecordType recordType, int flags, int dataSize, IntPtr data, PlayRecordCallback callbackData)

                    {
                        string str = " ";

                        // Play only EmfPlusRecordType.FillEllipse records

                        if (true)
                        {
                            str = "Record type:" + recordType.ToString() +
                            ", Flags:" + flags.ToString() +
                            ", Data :" + data.ToString();
                            System.Console.Out.WriteLine(str);
                        }

                        return true;
                    }

                }

            }
            catch
            {
                Log.e("RES", "Error accessing resources!");
            }
        }
    }
}
