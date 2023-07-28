import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

success = easypost.Billing.delete_payment_method(primary_or_secondary="primary")

print(success)
