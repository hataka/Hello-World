<?php // -*- mode: php -*-  Time-stamp: <2017-04-29 10:19:59 kahata>
/*================================================================
 * title: 
 * file: get_file.php
 * path: F:\GitHub\hataka\Hello-World\get_file.php
 * url:  F:/GitHub/hataka/Hello-World/get_file.php
 * created: Time-stamp: <2017-04-29 10:19:59 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: https://www.softel.co.jp/blogs/tech/archives/4766
 * description: 
 *	
		$raw    https://raw.githubusercontent.com/hataka/Hello-World/master/maven/mvn-app/build.xml
		$link             https://github.com/hataka/Hello-World/blob/master/maven/mvn-app/build.xml
		$url              https://github.com/hataka/Hello-World/tree/master/maven/mvn-app
		$match                              /hataka/Hello-World/blob/master/maven/mvn-app/build.xml
 *
 *================================================================*/

	$baseurl ="https://github.com/hataka/Hello-World";
	$listpath = array();

	$listpath = get_repository_filelist($baseurl,$listpath);
	print_r($listpath);
	get_repository_file($listpath, ".");
	
	
	function get_repository_filelist($url, $listpath){
		$pattern ="'<a href=\"(.+?)\" class=\"js-navigation-open\".+>(.+?)</a>'";
		//global $pattern,$listpath;	
		$html = file_get_contents($url);
		$count = preg_match_all($pattern,$html,$matches);
		//echo $count;//OK
		for($i = 0; $i<$count;$i++){
			//echo $matches[1][$i] . " : " .$matches[2][$i] ."\n";
			$link=$matches[1][$i];
			$label = $matches[2][$i];
			if(strpos($link, 'tree') > -1 && $label != "..") {
  			$listpath = get_repository_filelist("https://github.com".$link, $listpath);
  		} else {
				$link = "https://raw.githubusercontent.com" .$link;
				$link = str_replace("blob/","",$link);
				$response = @file_get_contents($link, NULL, NULL, 0, 1);
				if ($response !== false) {
					array_push($listpath,$link);
    			//echo '存在する';
				} else {
    			//echo '存在しない';
				}
  		}
		}
		return $listpath;
	}

	function get_repository_file($listpath, $distdir){
		foreach($listpath as $path){
			$output = str_replace("https://raw.githubusercontent.com","",$path);
			$output =$distdir.$output; 
			if(!file_exists(dirname($output))){
				if (!mkdir(dirname($output), 0777, true)) {
    			echo "failed to copy $path to $output\n";
					//return false;
				}
			}
			//echo $output."\n";
			if (!copy($path,$output)) {
    		echo "failed to copy $path to $output\n";
				//return false;
			}
		}
		//return true;
	}


