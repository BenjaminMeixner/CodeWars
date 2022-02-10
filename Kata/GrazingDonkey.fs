namespace Kata



open System
module GrazingDonkey =
    let OgreSteps diameter percentage =
        let radius = float diameter / 2.0
        let area = Math.Pow(radius, 2) * Math.PI
        let percentile = area * percentage
        let percentileRadius = Math.Pow((percentile / Math.PI), 0.5)
        let steps = percentileRadius + percentileRadius
        int steps