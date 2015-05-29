using System;

public class Class1
{
	public Class1()
	{
        ListNetworkComputers.NetworkBrowser nb = new ListNetworkComputers.NetworkBrowser();
        foreach (string pc in nb.getNetworkComputers())
        {
            listbox1.Items.Add(pc);
        }
	}
}
