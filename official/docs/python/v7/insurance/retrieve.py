import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

insurance = easypost.Insurance.retrieve("ins_...")

print(insurance)