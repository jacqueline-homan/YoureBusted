namespace YoureBusted

open System.Collections.Generic

module Types =

    type NGO =
        { OrgName : string
          EIN : int
          City : string
          State : string
        }

    type Needs =
        | Legal
        | Medical
        | Dental
        | Housing
        | Income
        | Education
        | SkillsTraining
        | Employment

    type Caller =
        | Survivor
        | Advocate

    type NgoType =
        | Awareness
        | VictimsServices
        | PovertyRelief


    type Followup =
        | NotFollowedUp // No caseworker followed up with caller
        | FollowedUp of Help

    and Help =
        | Helped // Terminal case: caller got helped
        | ExhaustedOptions // Caller not helped and exhausted all options
        | NotHelped of Followup
        | WrongHelp of Followup
        | Referred of RefToNextNgo

    and RefToNextNgo = RefToNextNgo of Followup * NGO

    type CallOutcome =
        | FullyHelped
        | PartlyHelped of Followup
        | Referred of RefToNextNgo
        | NotHelped of Followup

    type Request = Assistance of Set<Needs>

    type Call = Call of Caller * Request * CallOutcome 

