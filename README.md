<h1>PlayerPrefs Extensions</h1>
<b>New Methods:<br></b>
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
