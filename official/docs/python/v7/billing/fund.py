import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

billing = easypost.Billing.fund_wallet(
    amount="2000",
    primary_or_secondary="primary",
)

print(billing)