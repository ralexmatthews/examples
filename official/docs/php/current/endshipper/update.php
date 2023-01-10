<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$endshipper = $client->endShipper->retrieve('es_...');

$updatedEndShipper = $client->$endShipper->update(
    $endShipper->id,
    [
        'name' => 'NEW NAME',
        'company' => 'BAZ',
        'street1' => '164 TOWNSEND STREET UNIT 1',
        'street2' => 'UNIT 1',
        'city' => 'SAN FRANCISCO',
        'state' => 'CA',
        'zip' => '94107',
        'country' => 'US',
        'phone' => '555-555-5555',
        'email' => 'FOO@EXAMPLE.COM',
    ]
);

echo $updatedEndShipper;
