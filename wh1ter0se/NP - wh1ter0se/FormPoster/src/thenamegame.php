<?php
    $name = strtolower($_POST["name"]);
    $firstLineName = strpbrk($name, 'aeiou');
    $firstLine = '%1$s %1$s bo-b%2$s';
    $firstLineText = ucwords(sprintf($firstLine, $name, $firstLineName));
    $secondLine = 'banana-fana fo-f%s';
    $secondLineText = ucwords(sprintf($secondLine, $firstLineName));
    $thirdLine = 'fee-fi-fo-m%s';
    $thirdLineText = ucwords(sprintf($thirdLine, $firstLineName));
    
    $outputFormat = '%s, %s, %s, %s!';
    $output = sprintf($outputFormat, $firstLineText, $secondLineText, $thirdLineText, ucwords($name));
    // return $output here, idk how
    echo $output;
?>