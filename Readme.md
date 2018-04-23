# How to switch UI elements translation at runtime


<p>Sometimes you may want to implement the capability to switch application culture "on the fly". We think that the simplest solution is to modify the following property values of the current thread somewhere in application's code:</p><p><a href="http://msdn.microsoft.com/en-us/library/system.threading.thread.currentculture.aspx"><u>Thread.CurrentCulture</u></a><br />
<a href="http://msdn.microsoft.com/en-us/library/system.threading.thread.currentuiculture.aspx"><u>Thread.CurrentUICulture</u></a></p><p>Unfortunately, this approach will not work because, in general, these settings should be set only at the application startup before any controls' initialization. Otherwise, some controls might not accept changes.</p><p>Thus, the most appropriate solution to ensure that the application culture is updated is to completely restart the application. This example illustrates how this can be done by using the standard <a href="http://msdn.microsoft.com/en-us/library/system.windows.forms.application.restart.aspx"><u>Application.Restart Method</u></a>. Note that the necessary logic is implemented in the <strong>CultureSwitcher</strong> class that can be used as is in your own application.</p><p><strong>NOTE:</strong> Before running this example you need to unpack the fr.zip archive and make sure that its content is copied to the bin\Debug\fr folder of an application.</p>

<br/>


