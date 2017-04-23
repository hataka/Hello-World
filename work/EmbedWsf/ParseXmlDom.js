// -*- mode: js -*-  Time-stamp: <2017-04-11 18:44:15 kahata>
/*================================================================
 * title: 
 * file: xmldom.js
 * path: C:\Users\�a�F\Desktop\xmldom.js
 * url:  C:/Users/�a�F/Desktop/xmldom.js
 * created: Time-stamp: <2017-04-11 18:44:15 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://qiita.com/tnakagawa/items/4b501c21abcd39f30fbe
 * description: JScript��DOM(XML)����
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

// DOM�I�u�W�F�N�g����
var dom = new ActiveXObject("Msxml2.DOMDocument");
// ������
dom.async = false;
// �p�[�X
dom.loadXML(xml);
// �t�@�C���̏ꍇ
// dom.load(path);
// ���ʔ���
if (dom.parseError.errorCode == 0) {
	// XML�o��
	WScript.Echo(dom.xml);

	// aaa�^�O�擾
	var aaa = dom.selectSingleNode("//root/aaa");
	// �����l�擾
	WScript.Echo(aaa.getAttribute("attr"));

	// ���[�g�擾
	var root = dom.documentElement;
	// �^�O����bbb�̃G�������g�擾
	var elements = root.getElementsByTagName("bbb");
	// �G�������g�������[�v
	for (var i = 0; i < elements.length; i++) {
		// �G�������g�擾
		var element = elements[i];
		// �q�擾
		var child = element.firstChild;
		// ���̃^�O���ƃe�L�X�g�\��
		WScript.Echo(child.nodeName + ":" + child.text);
	}
} else {
	// �p�[�X���s�̏ꍇ
	WScript.Echo("parseError:" + dom.parseError.errorCode);
}
