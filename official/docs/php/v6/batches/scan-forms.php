<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$batch = $client->batch->retrieve('batch_...');

$batchWithScanForm = $client->batch->createScanForm($batch->id);

echo $batchWithScanForm;
