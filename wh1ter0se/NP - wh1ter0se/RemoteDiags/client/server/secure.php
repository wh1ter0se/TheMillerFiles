<?php
$cookie_name = "useless_value";
$cookie_value = "something";
setcookie($cookie_name, $cookie_value, time() + (86400), "/");
if(!isset($_COOKIE[$cookie_name])) { echo $cookie_name . "needs to be set";
	} else { echo $_COOKIE[$cookie_name]; }



$user = $_GET['user'];
$pass = $_GET['pass'];

if($user == "demiller"
&& $pass == "password1")
{ include("stats.php"); }
else {
    if(isset($_POST))
    {?>
            <form method="GET" action="secure.php">
            User <input type="text" name="user"></input><br/>
            Pass <input type="password" name="pass"></input><br/>
            <input type="submit" name="submit" value="Go"></input>
            </form>
    <?}
}
?>