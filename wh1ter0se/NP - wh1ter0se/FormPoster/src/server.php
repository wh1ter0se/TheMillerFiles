<?php
    define("SCHOOL", "Yorkville High School");
    
    $mySchool = $POST['school'];
    
    if ($mySchool == constant("SCHOOL"))
    	echo("Go Foxes!");
?>