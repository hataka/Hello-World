// -*- mode: js -*-  Time-stamp: <2017-04-11 18:49:47 kahata>
/*================================================================
 * title: 
 * file: CreateXmlDom.js
 * path: C:\Users\和彦\Desktop\CreateXmlDom.js
 * url:  C:/Users/和彦/Desktop/CreateXmlDom.js
 * created: Time-stamp: <2017-04-11 18:49:47 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://qiita.com/tnakagawa/items/4b501c21abcd39f30fbe
 * description: JScriptでDOM(XML)操作 生成
 *================================================================*/

// DOMオブジェクト生成
var dom = new ActiveXObject("Msxml2.DOMDocument");
// XML宣言部分生成
var head = dom.createProcessingInstruction("xml", "version='1.0'");
// XML宣言部分設定
dom.appendChild(head);

// ルート生成
var root = dom.createElement("root");

// aaaタグ生成
var aaa = dom.createElement("aaa");
// aaaタグ属性設定
aaa.setAttribute("attr", "rtta");
// aaaタグテキスト設定
aaa.text = "111";
// aaaタグをルートに追加
root.appendChild(aaa);

// アイテム数分ループ
var items = ["222", "333"];
for (var i = 0; i < items.length; i++) {
	// bbbタグ生成
	var bbb = dom.createElement("bbb");
	// cccタグ生成
	var ccc = dom.createElement("ccc");
	// cccタグテキスト設定
	ccc.text = items[i];
	// bbbタグにcccタグを追加
	bbb.appendChild(ccc);
	// bbbタグをルートに追加
	root.appendChild(bbb);
}

// DOMにrootを追加
dom.appendChild(root);

