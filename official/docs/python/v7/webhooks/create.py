import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

webhook = easypost.Webhook.create(url="example.com")

print(webhook)