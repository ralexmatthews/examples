import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

payload = easypost.Event.retrieve_payload("evt_...", "payload_...")

print(payload)
