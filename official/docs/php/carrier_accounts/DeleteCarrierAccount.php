<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$carrierAccount = \EasyPost\CarrierAccount::retrieve('ca_...');

$carrierAccount->delete();

echo $carrierAccount;
