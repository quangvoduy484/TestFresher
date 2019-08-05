using RadarWebModels.Models;
using RadarWebService.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace RadarWebService.Hepler
{
  public class NewEntityModel
  {
    public GeofencesModel NewGeofences(Geofence geofence)
    {
      GeofencesModel aNewGeofence = new GeofencesModel();
      aNewGeofence.Id = geofence?._id ?? null;
      aNewGeofence.CreateAt = geofence.createdAt;
      aNewGeofence.Description = geofence?.description ?? null;
      aNewGeofence.Enabled = true;
      aNewGeofence.ExternalId = geofence?.externalId ?? null;
      aNewGeofence.GeometryCenterType = geofence?.geometryCenter?.type ?? null;
      aNewGeofence.GeometryCenterLatitude = geofence?.geometryCenter?.coordinates[1] ?? 0;
      aNewGeofence.GeometryCenterLongitude = geofence?.geometryCenter?.coordinates[0] ?? 0;
      aNewGeofence.GeometryRadius = geofence.geometryRadius;//need
      aNewGeofence.UserId = geofence?.UserId ?? null;//optional
      aNewGeofence.Tag = geofence?.tag;//optional
      aNewGeofence.Live = geofence.live; // not post column when your add geofences, but I must check api key live(true) or test(false)   
      aNewGeofence.Type = geofence?.type ?? null;//need
      return aNewGeofence;
    }

    public User NewUser(RadarWebModels.Models.UserModel user)
    {
      User aNewUser = new User();
      aNewUser.Id = user?._id ?? null;
      aNewUser.Live = user.live;
      aNewUser.UserId = user?.userId ?? null;
      aNewUser.DeviceId = user?.deviceId ?? null;
      aNewUser.Description = user?.description ?? null;
      aNewUser.LocationType = user?.Location.type ?? null;
      aNewUser.Latitude = user.Location.coordinates[0];
      aNewUser.Longitude = user.Location.coordinates[1];
      aNewUser.ExternalId = user?.externalId ?? null;
      aNewUser.UpdatedAt = user.updatedAt;
      aNewUser.DeviceType = user?.deviceType ?? null;
      aNewUser.LocationAccuracy = user.locationAccuracy;
      aNewUser.Stopped = user.stopped;
      aNewUser.Foreground = user.foreground;
      aNewUser.Ip = user?.ip ?? null;
      return aNewUser;

    }

    public MetaData NewMetaData(KeyValuePair<string, object> metadata, string id, string type)
    {
      MetaData aNewMetadata = new MetaData();
      aNewMetadata.Key = metadata.Key;
      aNewMetadata.Value = metadata.Value.ToString();
      aNewMetadata.ObjectId = id;
      aNewMetadata.Object = type;
      return aNewMetadata;
    }

    public Event NewEvents(RadarWebModels.Models.EventModel eventModel, UserModel userModel)
    {
      Event events = new Event();
      events.Id = eventModel?._id ?? null;
      events.Confidence = eventModel.confidence;
      events.CreateAt = eventModel.createdAt;
      events.Duration = eventModel.duration;
      events.GeofenceId = eventModel.geofence._id;
      events.Live = eventModel.live; // the same geofences
      events.LoactionAccurary = eventModel.locationAccuracy;
      events.Latitude = eventModel.location.coordinates[1];
      events.Longitude = eventModel.location.coordinates[0];
      events.LocationType = eventModel?.location.type;
      events.Type = eventModel.type;
      events.UserId = userModel._id; ;
      events.Verification = eventModel.verification;
      return events;
    }
  }
}
