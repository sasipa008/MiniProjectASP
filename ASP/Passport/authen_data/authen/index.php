<?
// ------------------------------------ �ѧ���� 㹡����ա�� PSU PASSPORT ------------------------------
/* Load factory class */

require_once("libraries/nusoap.php");   // ------------------------------------ Class 㹡�����¡�� ����ͧ任�Ѻ������ ------------------------------

$proxyhost = '';$proxyport ='';

     $client = new nusoapclient("http://passport.phuket.psu.ac.th/authentication/authentication.asmx",false,$proxyhost, $proxyport);
	$client->soap_defencoding = 'utf-8';
	$params = array(
            'username' =>  $_POST['txtUserId'],
            'password' =>  $_POST['txtPassword']
        );
        
 $result = $client->call('GetUserDetails', $params, 'http://tempuri.org/', 'http://tempuri.org/GetUserDetails', false, false, 'rpc', 'literal');

		$err = $client->getError();
		
		if ($err) 
		{
				// if error 
		}
	else {				
				// else login success
				

					for ($i = 0; $i <= 20; $i++) 
					{
  					echo $result[$i]."<br/>";
					}
					
			}

?>




<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
  "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=tis-620"/>

  
</head>
<body>
      
<form class="signin" method="post">
  <fieldset class="common-form standard-form">
    <table cellspacing="0" width="95%">
      <tr>
        <th><label for="txtUserId">Username</label></th>

        <td><input id="txtUserId" name="txtUserId" type="text" value="" /></td>
      </tr>
      <tr>
        <th><label for="txtPassword">Password</label></th>
        <td><input id="txtPassword" name="txtPassword" type="password" value="" /></td>
      </tr>
           
      <tr>
        <th></th>
        <td><input class="btn btn-m" id="signin_submit" name="commit" type="submit" value="Sign In" /></td>
      </tr>
    </table>

  </fieldset>
</form>

<?
for ($i = 0; $i <= 20; $i++) 
					{
  					echo $result[$i]."<br/>";
					}
?>


</body>
</html>