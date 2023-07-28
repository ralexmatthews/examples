import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

batch = easypost.Batch.retrieve("batch_...")

batch.create_scan_form()

print(batch)
