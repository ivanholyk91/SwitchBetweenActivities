package md5d5730ef4dda0387dcb75cd522bc0c780;


public class RecvActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("SwitchBetweenActivities.RecvActivity, SwitchBetweenActivities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RecvActivity.class, __md_methods);
	}


	public RecvActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RecvActivity.class)
			mono.android.TypeManager.Activate ("SwitchBetweenActivities.RecvActivity, SwitchBetweenActivities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
