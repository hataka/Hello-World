// -*- mode: js -*-  Time-stamp: <2017-04-11 18:44:15 kahata>
/*================================================================
 * title: 
 * file: xmldom.js
 * path: C:\Users\和彦\Desktop\xmldom.js
 * url:  C:/Users/和彦/Desktop/xmldom.js
 * created: Time-stamp: <2017-04-11 18:44:15 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://qiita.com/tnakagawa/items/4b501c21abcd39f30fbe
 * description: JScriptでDOM(XML)操作
 *================================================================*/

// XML
var xml = "<?xml version='1.0'?>\r\n"
		+ "<root>\r\n"
		+ "	<aaa attr='rtta'>111</aaa>\r\n"
		+ "	<bbb>\r\n"
		+ "		<ccc>222</ccc>\r\n"
		+ "	</bbb>\r\n"
		+ "	<bbb>\r\n"
		+ "		<ccc>333</ccc>\r\n"
		+ "	</bbb>\r\n"
		+ "</root>\r\n";

// DOMオブジェクト生成
var dom = new ActiveXObject("Msxml2.DOMDocument");
// 同期化
dom.async = false;
// パース
dom.loadXML(xml);
// ファイルの場合
// dom.load(path);
// 結果判定
if (dom.parseError.errorCode == 0) {
	// XML出力
	WScript.Echo(dom.xml);

	// aaaタグ取得
	var aaa = dom.selectSingleNode("//root/aaa");
	// 属性値取得
	WScript.Echo(aaa.getAttribute("attr"));

	// ルート取得
	var root = dom.documentElement;
	// タグ名がbbbのエレメント取得
	var elements = root.getElementsByTagName("bbb");
	// エレメント数分ループ
	for (var i = 0; i < elements.length; i++) {
		// エレメント取得
		var element = elements[i];
		// 子取得
		var child = element.firstChild;
		// このタグ名とテキスト表示
		WScript.Echo(child.nodeName + ":" + child.text);
	}
} else {
	// パース失敗の場合
	WScript.Echo("parseError:" + dom.parseError.errorCode);
}
