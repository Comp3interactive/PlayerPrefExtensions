<h1>PlayerPrefs Extensions</h1>
<p>
Simply put this script anywhere inside your project's asset folder and call the static methods from wherever you require.
<p>
<b>New Methods:</b>
<pre>
SetBool(string key, bool val)
GetBool(string key)
SetVector3(string key, Vector3 v3)
GetVector3(string key)
SetVector2(string key, Vector2 v2)
GetVector2(string key)
SetQuaternion(string key, Quaternion q)
GetQuaternion(string key)
</pre>
<p>
These methods can be used in exactly the same way as the standard Unity PlayerPrefs system. Simply call <code>Comp3PlayerPrefs.SetBool("MyBool", true);</code> for example and then to retrieve call <code>Comp3PlayerPrefs.GetBool("MyBool");</code>
<p>
The standard <code>PlayerPrefs.HasKey(string key);</code> and <code>PlayerPrefs.DeleteAll();</code> methods will include these new PlayerPrefs too!
