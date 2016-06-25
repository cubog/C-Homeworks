package md5c2ee7098d2f3ac3730e723c139280b40;


public class MainActivity_HybridWeb2
	extends android.webkit.WebChromeClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPermissionRequest:(Landroid/webkit/PermissionRequest;)V:GetOnPermissionRequest_Landroid_webkit_PermissionRequest_Handler\n" +
			"";
		mono.android.Runtime.register ("WebViewRTC.MainActivity+HybridWeb2, WebViewRTC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity_HybridWeb2.class, __md_methods);
	}


	public MainActivity_HybridWeb2 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity_HybridWeb2.class)
			mono.android.TypeManager.Activate ("WebViewRTC.MainActivity+HybridWeb2, WebViewRTC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onPermissionRequest (android.webkit.PermissionRequest p0)
	{
		n_onPermissionRequest (p0);
	}

	private native void n_onPermissionRequest (android.webkit.PermissionRequest p0);

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
