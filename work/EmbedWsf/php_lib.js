//////////////////////////////////////////////////////////////////
// php ƒ‰ƒCƒuƒ‰ƒŠ
function ComandOutput(phpfile){
	var executable = "C:\\eclipse461\\xampp\\php\\php.exe";
	var shell = new ActiveXObject("WScript.Shell");
	shell.Run("cmd.exe /k "+ executable + "  "+ phpfile, 1, false);
}

function ChromeOutput(phpfile){
	var executable = "C:\\eclipse461\\xampp\\php\\php.exe";
	var browser = "\"" + "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe" + "\"";
	//	var phpfile  = "F:\\php1\\sslib\\sslib212.php";
	var htmlfile = "Main.html"
	var shell = new ActiveXObject("WScript.Shell");
	var oe = shell.exec(executable + "  "+ phpfile);
	var html = oe.StdOut.ReadAll();
  shell.Run(browser + "  "+ createTempFile(html,htmlfile), 1, false);
}

