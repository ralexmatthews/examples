import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

shipment = easypost.Shipment.retrieve("shp_...")
shipment.refund()

print(shipment)
