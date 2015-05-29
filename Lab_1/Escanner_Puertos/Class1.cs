using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Collections;
using System.Windows.Forms;

namespace ListNetworkComputers {
    public sealed class NetworkBrowser {
        public NetworkBrowser() { 
        }
//zona de importar librerias[]
        public static extern int NetServerEnum(
            string ServerName,
            int dwLevel,
            ref IntPtr pBuf,
            int dwPrefMaxLen,
            out int dwEntriesRead,
            out int dwTotalEntries,
            int dwServerType,
            string domain,
            out int dwResumeHandle);
        [DllImport("Netapi32", SetLastError = true), SuppressUnmanagedCodeSecurityAttribute]
        public static extern int NetApiBufferFree(IntPtr pBuf);
        [StructLayout(LayoutKind.Sequential)]
        public struct _SERVER_INFO_100 {
            internal int sv100_platform_id;
            [MarshalAs(UnmanagedType.LPWStr)]
            internal string sv100_name;
        }
//fin de la zona
    }
//zona de los métodos públicos
    public ArrayList getNetworkComputers(){
        ArrayList networkComputers = new ArrayList();
        const int MAX_PREFERRED_LENGTH = -1;
        int SV_TYPE_WORKSTATION = 1;
        int SV_TYPE_SERVER = 2;
        IntPtr buffer = IntPtr.Zero;
        IntPtr tmpBuffer = IntPtr.Zero;
        int entriesRead = 0;
        int totalEntries = 0;
        int resHandle = 0;
        int sizeofINFO = Marshal.SizeOf(typeof(_SERVER_INFO_100));
        try{
            int ret = NetServerEnum(null, 100, ref buffer, MAX_PREFERRED_LENGTH, out entriesRead, out totalEntries, SV_TYPE_WORKSTATION | SV_TYPE_SERVER, null, out resHandle);
            if (ret == 0){
                for (int i = 0; i < totalEntries; i++){
                    tmpBuffer = new IntPtr((int)buffer + (i * sizeofINFO));
                    _SERVER_INFO_100 svrInfo = (_SERVER_INFO_100)
                    Marshal.PtrToStructure(tmpBuffer, typeof(_SERVER_INFO_100));
                    networkComputers.Add(svrInfo.sv100_name);
                }
            }
        }catch(Exception ex){
            MessageBox.Show("Problem with acessing network computers in NetworkBrowser " +
            "\r\n\r\n\r\n" + ex.Message,
            "Error", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
            return null;
        }finally{
            NetApiBufferFree(buffer);
        }
        return networkComputers;
    }
//fin de la zona de métodos públicos
}

public class Class1
{
	public Class1()
	{
	}
}
