<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$pickup = \EasyPost\Pickup::retrieve('pickup_...');

echo $pickup;