SELECT STAFF.staffID
FROM STAFF
INNER JOIN STAFF_MAINTENANCE
ON STAFF.staffID = STAFF_MAINTENANCE.staffID
INNER JOIN MAINTENANCE 
ON STAFF_MAINTENANCE.maintenanceID = MAINTENANCE.maintenanceID
WHERE  NOT dateOfMaintenance BETWEEN '{0}' and '{2}'
AND NOT DATEADD(MINUTE, '{0}', dateOfMaintenance) BETWEEN '{0}' and '{2}'
AND NOT '{1}' BETWEEN dateOfMaintenance and DATEADD(MINUTE, '{0}', dateOfMaintenance)
AND NOT '{2}' BETWEEN dateOfMaintenance and DATEADD(MINUTE, '{0}', dateOfMaintenance)