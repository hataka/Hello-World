// -*- mode: js -*-  Time-stamp: <2017-04-11 18:49:47 kahata>
/*================================================================
 * title: 
 * file: CreateXmlDom.js
 * path: C:\Users\�a�F\Desktop\CreateXmlDom.js
 * url:  C:/Users/�a�F/Desktop/CreateXmlDom.js
 * created: Time-stamp: <2017-04-11 18:49:47 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://qiita.com/tnakagawa/items/4b501c21abcd39f30fbe
 * description: JScript��DOM(XML)���� ����
 *================================================================*/

// DOM�I�u�W�F�N�g����
var dom = new ActiveXObject("Msxml2.DOMDocument");
// XML�錾��������
var head = dom.createProcessingInstruction("xml", "version='1.0'");
// XML�錾�����ݒ�
dom.appendChild(head);

// ���[�g����
var root = dom.createElement("root");

// aaa�^�O����
var aaa = dom.createElement("aaa");
// aaa�^�O�����ݒ�
aaa.setAttribute("attr", "rtta");
// aaa�^�O�e�L�X�g�ݒ�
aaa.text = "111";
// aaa�^�O�����[�g�ɒǉ�
root.appendChild(aaa);

// �A�C�e���������[�v
var items = ["222", "333"];
for (var i = 0; i < items.length; i++) {
	// bbb�^�O����
	var bbb = dom.createElement("bbb");
	// ccc�^�O����
	var ccc = dom.createElement("ccc");
	// ccc�^�O�e�L�X�g�ݒ�
	ccc.text = items[i];
	// bbb�^�O��ccc�^�O��ǉ�
	bbb.appendChild(ccc);
	// bbb�^�O�����[�g�ɒǉ�
	root.appendChild(bbb);
}

// DOM��root��ǉ�
dom.appendChild(root);

