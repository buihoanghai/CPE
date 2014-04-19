$(document).ready(function(){
    select;
$('#member-login').magnificPopup({
  items: {
      src: '<div class="white-popup login-popup"><h1>Member Login</h1><div class="content clearfix"><table style="float:left;font-size:12px;" width="100%">'+
                '<tr><td><strong>Username</strong></td><td><input id="Username" name="Username" type="text" ></td></tr>' +
                '<tr><td><strong>Password</strong></td><td><input id="Password" name="Password" type="password" ></td></tr>' +
                '<tr><td colspan=2><input type="checkbox" ><span style="font-size:10px;">'+
                'Remember my Username & Password on this browser.<span></td></tr>'+
                '<tr><td colspan=2><center>Need help Signing In?<br><span class="orange">Forgot my password</span</center>></td></tr>'+
                '<tr><td colspan=2><center><input onclick="_guestLogin();" type="button" class="submit" value="GUEST LOGIN"></center></td></tr>' +
                '<tr><td colspan=2><center>Not a Member?<br><span class="orange">Join now ( Free )</span></center></td></tr>'+
                '<tr><td colspan=2><center><input onclick="_LoginCustomer();" type="button" class="submit" value="LOGIN"></center></td></tr>' +
            '</div></div>',
      type: 'inline'
  },
  closeBtnInside: true
});

$('#delivery').magnificPopup({
  items: {
      src: '<div class="white-popup">        <h1>Delivery</h1><div class="content clearfix">            <table style="float:left;font-size:12px;" width="100%">                <tbody><tr><td><strong>Device Qty</strong></td><td>    <select data-val="true" data-val-number="The field DeviceQTY must be a number." data-val-required="The DeviceQTY field is required." id="DeviceQTY" name="DeviceQTY"><option value="1">1</option><option value="2">2</option><option value="3">3</option><option value="4">4</option><option value="5">5</option><option value="6">6</option><option value="7">7</option><option value="8">8</option><option value="9">9</option><option value="10">10</option></select></td></tr>                <tr>                    <td><strong>Delivery Date</strong></td>                    <td>                        <input class="dateSelects" data-val="true" data-val-date="The field DeliveryDate must be a date." data-val-required="The DeliveryDate field is required." id="DeliveryDate" name="DeliveryDate" style="width: 97px;" type="text" value="">                    </td>                    <td><div class="date-icon"></div></td>                </tr>                 <tr>                    <td><strong>Delivery Time</strong></td>                    <td>                        <select data-val="true" data-val-number="The field DeliveryTime must be a number." data-val-required="The DeliveryTime field is required." id="DeliveryTime" name="DeliveryTime"><option value="8">8 AM</option><option value="9">9 AM</option><option value="20">8 PM</option></select>                    </td>                </tr>                <tr>                    <td><strong>Return Date</strong></td>                   <td><input class="dateSelects" data-val="true" data-val-date="The field ReturnDate must be a date." data-val-required="The ReturnDate field is required." id="ReturnDate" name="ReturnDate" style="width: 97px;" type="text" value=""></td>                    <td><div class="date-icon"></div></td>                </tr>                 <tr>                    <td><strong>Return Time</strong></td>                    <td>                        <select data-val="true" data-val-number="The field ReturnTime must be a number." data-val-required="The ReturnTime field is required." id="ReturnTime" name="ReturnTime"><option value="8">8 AM</option><option value="9">9 AM</option><option value="20">8 PM</option></select>                    </td>                </tr>                <tr>                    <td>                        <strong>                            Name of person who booked the hotel                            <span title="Name of person who reserve the hotel room. Whom the device will also be attention to for your device delivery.    " style="color:#f85600;font-size:10px;">[?]</span>            </strong>        </td>        <td><input id="BookedName" name="BookedName" type="text" value=""></td>    </tr><tr>        <td><strong>Delivery Address</strong></td>        <td>            <textarea cols="20" id="DeliveryAddress" name="DeliveryAddress" rows="2" style="margin-top: 2px; margin-bottom: 2px; height: 32px;"></textarea>                                </td>                    </tr><tr id="idPromotion"><td><strong>Promotional Code</strong></td><td><input id="PromotionCode" name="PromotionCode" type="text" value=""></td></tr>                <tr id="idAgent">                    <td><strong>Agent Code</strong></td>                    <td>                        <input id="AgentCode" name="AgentCode" type="text" value=""></td></tr><tr><td colspan="2"><input onclick="_Delivery();" type="button" class="submit" value="SUBMIT" style="margin-left:10px;float:left;margin-left:100px;"></td></tr></tbody></table><div class="left">Need help Signing In?<br><span class="orange">Forgot my password</span></div><div class="right">Not a Member?<br><span class="orange">Join now ( Free )</span></div></div></div><script>$(".dateSelects").datepicker();</script>',
      type: 'inline'
  },
  closeBtnInside: true
});
$('#self-collect').magnificPopup({
  items: {
      src: '<div class="white-popup"><h1>Self Collect & Return</h1>'+
      '<div class="content clearfix"><table style="float:left;font-size:12px;" width="100%">'+
                '<tr><td><strong>Device Qty</strong></td><td><select data-val="true" data-val-number="The field DeviceQTY must be a number." data-val-required="The DeviceQTY field is required." id="DeviceQTY" name="DeviceQTY"><option value="1">1</option><option value="2">2</option><option value="3">3</option><option value="4">4</option><option value="5">5</option><option value="6">6</option><option value="7">7</option><option value="8">8</option><option value="9">9</option><option value="10">10</option></select></td></tr>' +
                '<tr><td><strong>Pickup Location</strong></td><td>'+
                
                
                select+
                
                '</td></tr>'+
                '<tr><td><strong>Pickup Date</strong></td><td><input class="dateSelects" data-val="true" data-val-date="The field DeliveryDate must be a date." data-val-required="The DeliveryDate field is required." id="PickDate" name="PickDate" style="width: 135px;" type="text" value=""></td>' +
                '<td><div class="date-icon"></div></td></tr> </tr>'+
                '<tr><td><strong>Return Date</strong></td><td><input class="dateSelects" data-val="true" data-val-date="The field ReturnDate must be a date." data-val-required="The ReturnDate field is required." id="ReturnDate" name="ReturnDate" style="width: 135px;" type="text" value=""></td>' +
                '<td><div class="date-icon"></div></td></tr> </tr>'+
                '<tr><td colspan=2><input type="checkbox" ><span style="font-size:10px;">'+
                'Enter a Promotional or Agent Code?<span></td></tr>'+
                '<tr><td><strong>Promotional Code</strong></td><td><input id="PromotionCode" name="PromotionCode" type="text" value=""></td></tr>' +
                '<tr><td><strong>Agent Code</strong></td><td><input id="AgentCode" name="AgentCode" type="text" value=""></td></tr>' +
                '<tr><td colspan=2>'+
                '<input onclick="_SelfReturn();" type="button" class="submit" value="SUBMIT" style="margin-left:10px;float:left;margin-left:100px;"></td></tr></table>' +
                '<div class="left">Need help Signing In?<br><span class="orange">Forgot my password</span></div>'+
                '<div class="right">Not a Member?<br><span class="orange">Join now ( Free )</span></div>'+
            '</div></div><script>$(".dateSelects").datepicker();</script>',
      type: 'inline'
  },
  closeBtnInside: true
});

    
$('#cancel-res1').magnificPopup({
  items: {
      src: '<div class="white-popup" style="max-width:340px;width:340px;"><h1>View/Cancel/Modify a Reservation</h1><div class="content clearfix"><table style="float:left;font-size:12px;" width="100%">'+
                '<tr><td><strong>Confirmation Code</strong></td><td><input type="text"></td></tr>'+
                '<tr><td colspan=2><strong><center>AND</center></strong></td></tr>'+
                '<tr><td>Identity Number</td><td>'+
                '<input type="text" placeholder="630XXXXXXXX" style="border-top-right-radius:0;border-bottom-right-radius:0;width:100px;">'+
                '<select style="border-top-left-radius:0;border-bottom-left-radius:0; margin-left:-11px;width:93px;">'+
                '<option>Passport</option>'+
                '<option>National Identity Card</option>'+
                '<option>Driving License</option></select>'+
                '</td></tr>'+
                '<tr><td colspan=2><strong><center>OR</center></strong></td></tr>'+
                '<tr><td colspan=2>First Name : <input type="text" style="width:80px;"> '+
                ' Last Name :<input type="text"  style="width:80px;"></td></tr>'+
                '<tr><td colspan=2>'+
                '<input type="button" class="submit" value="SUBMIT" style="margin-left:10px;float:left;margin-left:100px;">'+
                '</td></tr></table>',
      type: 'inline'
  },
  closeBtnInside: true
});


});
