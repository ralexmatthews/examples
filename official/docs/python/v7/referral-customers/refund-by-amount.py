import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

refund = easypost.beta.Referral.refund_by_amount(refund_amount=2000)

print(refund)
