<?php
$user = $_POST['user'];
$pass = $_POST['pass'];

if($user == "demiller"
&& $pass == "password1")
{
        include("stats.php");
}
else {
    if(isset($_POST))
    {?>
            <form method="POST" action="secure.php">
            User <input type="text" name="user"></input><br/>
            Pass <input type="password" name="pass"></input><br/>
            <input type="submit" name="submit" value="Go"></input>
            </form>
    <?}
}
?>